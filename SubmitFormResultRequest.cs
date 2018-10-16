using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace CD.CIS.OutboundFormGenerator.Messages
{
    [Serializable]

    [XmlType(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsMessages.xsd")]
    [XmlRoot(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsMessages.xsd", IsNullable = false)]
    public partial class SubmitFormResultRequest
    {
        public SubmitFormResultRequestResult Result;
    }

    [XmlType(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsMessages.xsd")]
    public partial class SubmitFormResultRequestResult
    {
        [XmlElement(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public User User;

        [XmlElement(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public System.DateTime Date;

        [XmlElement(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public Form Form;

        [XmlElement(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public Association Association;

        [XmlElement(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public Responses[] Responses;

        [XmlElement(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string ResultGuid;
    }

    [XmlType(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    [XmlRoot(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd", IsNullable = false)]
    public class User
    {
        [XmlElement(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/03/CommonTypes.xsd")]
        public ushort ID;

        [XmlElement(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/03/CommonTypes.xsd")]
        public string Name;

        [XmlElement(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/03/CommonTypes.xsd")]
        public string DeviceID;

        [XmlElement(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/03/CommonTypes.xsd")]
        public object Attributes;
    }

    [XmlType(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    [XmlRoot(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd", IsNullable = false)]
    public class Form
    {
        public string Reference;
        public byte Version;
    }

    [XmlRoot(ElementName = "Association")]
    [XmlType(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd", TypeName = "VisitAssociationType")]
    public class Association
    {
        [XmlElement("WorkType", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string WorkType;

        [XmlElement("Reference", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string Reference;
    }

    [XmlRoot(ElementName = "Response")]
    [XmlType(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd", TypeName = "GroupResponseType")]
    public class GroupResponse
    {
        [XmlElement("Element", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public GroupResponseElement Element;

        [XmlElement("Instance", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public byte Instance;

        [XmlElement("Responses", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public ResponsesResponseResponse[] Responses;
    }

    [XmlType(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    public class GroupResponseElement
    {
        [XmlElement("Reference", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string Reference;
        [XmlElement("Text", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string Text;
    }

   // [XmlRoot(ElementName = "Response")]
    //[XmlType(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    [XmlType(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]//, TypeName = "ElementResponseType")]
    public partial class ResponsesResponseResponse
    {
        [XmlElement("Element", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public ResponsesResponseResponseElement Element;

        [XmlElement("Value", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public ResponsesResponseResponseValue Value;

        [XmlElement("Description", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string Description;

    }

    [XmlType(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    public partial class ResponsesResponseResponseElement
    {
        [XmlElement("Reference", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string Reference;

        [XmlElement("Text", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string Text;
   }

    [XmlType(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    public partial class ResponsesResponseResponseValue
    {
        [XmlElement("Content", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string Content;

        [XmlElement("MimeType", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string MimeType;

        [XmlTextAttribute()]
        public string[] Text;
    }

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd", IsNullable = false)]
    public partial class Responses
    {
        [System.Xml.Serialization.XmlElementAttribute("Response")]
        public GroupResponse[] Response;
    }



    /*
    [XmlRoot(ElementName = "Response")]
    [XmlType(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd", TypeName = "ElementResponseType")]
    public class ElementResponse
    {
        [XmlElement("Element", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public Element Element;

        [XmlElement("Value", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string ElementResponseValue;

        [XmlElement("Description", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string ElementResponseDescription;
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    public class Element
    {
        [XmlElement("Reference", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string Reference;

        [XmlElement("Text", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string Text;
    }


    [XmlRoot(ElementName = "Response")]
    [XmlType(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd", TypeName = "BinaryResponseType")]
    public class BinaryResponse
    {
        [XmlElement("Element", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public Element Element;

        [XmlElement("Value", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public BinaryResponseValue BinaryResponseValue;
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    public class BinaryResponseValue
    {
        [XmlElement("Content", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string Content;

        [XmlElement("MimeType", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string MimeType;

        [XmlElement("Text", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public string[] Text;

    }

    */

    /*
    [XmlType(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    [XmlRoot(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd", IsNullable = false)]
    public class Responses
    {
        [XmlElement("Response", Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
        public GroupResponse[] Response;
    }


    */


    /*
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    public partial class ResponsesResponse
    {
        public ResponsesResponseElement Element;

        public byte Instance;

        [System.Xml.Serialization.XmlArrayItemAttribute("Response", IsNullable = false)]
        public ResponsesResponseResponse[] Responses;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    public partial class ResponsesResponseElement
    {
        public string Reference;
        public string Text;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    public partial class ResponsesResponseResponse
    {

        private ResponsesResponseResponseElement Element;

        private ResponsesResponseResponseValue Value;

        private string Description;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    public partial class ResponsesResponseResponseElement
    {
        public string Reference;

        public string Text;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    public partial class ResponsesResponseResponseValue
    {
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/03/CommonTypes.xsd")]
        private string Content;

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/03/CommonTypes.xsd")]
        private string MimeType;

        [System.Xml.Serialization.XmlTextAttribute()]
        private string[] Text;

    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.consiliumtechnologies.com/mobile/2009/07/FormsTypes.xsd", IsNullable = false)]
    public partial class Responses
    {
        [System.Xml.Serialization.XmlElementAttribute("Response")]
        private ResponsesResponse[] Response;
     }
     */
}
