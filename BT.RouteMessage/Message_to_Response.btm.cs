namespace BT.RouteMessage {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BT.RouteMessage.Message", typeof(global::BT.RouteMessage.Message))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BT.RouteMessage.Response", typeof(global::BT.RouteMessage.Response))]
    public sealed class Message_to_Response : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://BT.RouteMessage.Response"" xmlns:s0=""http://BT.RouteMessage.Message"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Message"" />
  </xsl:template>
  <xsl:template match=""/s0:Message"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;Dit is een antwoord op: &quot; , string(s0:Content/text()))"" />
    <ns0:Response>
      <xsl:attribute name=""ReceiveDT"">
        <xsl:value-of select=""$var:v1"" />
      </xsl:attribute>
      <Content>
        <xsl:value-of select=""$var:v2"" />
      </Content>
    </ns0:Response>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}


public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BT.RouteMessage.Message";
        
        private const global::BT.RouteMessage.Message _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BT.RouteMessage.Response";
        
        private const global::BT.RouteMessage.Response _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BT.RouteMessage.Message";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BT.RouteMessage.Response";
                return _TrgSchemas;
            }
        }
    }
}
