using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace XmlStore
{
    public partial class XPathForm : Form
    {
        public XPathForm(String fileName)
        {
            InitializeComponent();
            loadXmlTree(fileName);
        }
        /// <summary>
        /// Loads XML tree nodes
        /// </summary>
        /// <param name="fileName"></param>
        private void loadXmlTree(String fileName)
        {
            xmlTreeView.Nodes.Clear();
            // Load the XML Document
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(fileName);
                xml = doc.InnerXml;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "XPath validator could not load xml file.");
                return;
            }

            ConvertXmlNodeToTreeNode(doc, xmlTreeView.Nodes);
            xmlTreeView.Nodes[0].ExpandAll();
        }
        /// <summary>
        /// Converts XML nodes to tree nodes for display
        /// </summary>
        /// <param name="xmlNode"></param>
        /// <param name="treeNodes"></param>
        private void ConvertXmlNodeToTreeNode(XmlNode xmlNode, TreeNodeCollection treeNodes)
        {
            TreeNode newTreeNode = treeNodes.Add(xmlNode.Name);

            switch (xmlNode.NodeType)
            {
                case XmlNodeType.ProcessingInstruction:
                case XmlNodeType.XmlDeclaration:
                    newTreeNode.Text = "<?" + xmlNode.Name + " " +
                      xmlNode.Value + "?>";
                    break;
                case XmlNodeType.Element:
                    newTreeNode.Text = "<" + xmlNode.Name + ">";
                    break;
                case XmlNodeType.Attribute:
                    newTreeNode.Text = "ATTRIBUTE: " + xmlNode.Name;
                    break;
                case XmlNodeType.Text:
                case XmlNodeType.CDATA:
                    newTreeNode.Text = xmlNode.Value;
                    break;
                case XmlNodeType.Comment:
                    newTreeNode.Text = "<!--" + xmlNode.Value + "-->";
                    break;
            }

            if (xmlNode.Attributes != null)
            {
                foreach (XmlAttribute attribute in xmlNode.Attributes)
                {
                    ConvertXmlNodeToTreeNode(attribute, newTreeNode.Nodes);
                }
            }
            foreach (XmlNode childNode in xmlNode.ChildNodes)
            {
                ConvertXmlNodeToTreeNode(childNode, newTreeNode.Nodes);
            }
        }
        /// <summary>
        /// Validates xpath
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xPathValidateButton_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();

                xmlDocument.LoadXml(xml);
                XPathNavigator nav = xmlDocument.CreateNavigator();
                if (String.IsNullOrEmpty(XPathTextBox.Text))
                    return;
                XPathNodeIterator iter = nav.Select(XPathTextBox.Text);
                StringBuilder results = new StringBuilder();
                while (iter.MoveNext())
                {
                    results.Append(iter.Current.OuterXml);
                }

                if (iter.Count == 0)
                    resultsRichTextBox.Text = "No matches found.";
                else
                    resultsRichTextBox.Text = results.ToString();
                errorsRichTextBox.Text = "No errors.";
            }
            catch (Exception ex)
            {
                resultsRichTextBox.Text = "Errors occurred while validating. Check \"Error\" tab for more details.";
                errorsRichTextBox.Text = String.Empty;
                errorsRichTextBox.Text = ex.ToString();
            }

        }

        private String xml;
    }
}
