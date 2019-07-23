using System;
using Tizen;

namespace GAssist
{
    internal class HtmlResponseParser
    {
        public static string ParseHtmlResponse(string html)
       {
            //  var asisOld = "assistant-bar-content";
            //  var asisNew = "assistant-bar-content{background-color: black;height: 0px !important; visibility: collapse !important; display: none !important;}";
            //  var positionAbs = "position: fixed;";
            var htmlOld = "html";
            var htmlNew = "html{ background-color: black;}";
            var popoutOld = "#popout{";
            var popoutNew = "#popout{ -moz-transform: scale(0.5, 0.5); zoom: 0.5; zoom: 50%;margin-top:50px;background-color: black;";
            var assistbarOld = "#carousel-container{";
            var assistbarNew = "#carousel-container{-moz-transform: scale(0.5, 0.5); zoom: 0.5; zoom: 30%;";
            var flex = "display:-webkit-flex;";
            var wrap = "display: -webkit-flex;\nheight: 300px;\nwidth: 160%;\n-webkit-flex-wrap: wrap;\n-webkit-flex-shrink: 1; scale = 1, maximum - scale = 0;";

            return html.Replace(popoutOld, popoutNew).Replace(flex, wrap).Replace(assistbarOld, assistbarNew).Replace(htmlOld, htmlNew);
        }

    }
}
