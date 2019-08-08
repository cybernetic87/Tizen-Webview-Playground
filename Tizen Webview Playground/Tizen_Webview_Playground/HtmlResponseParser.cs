using System;
using Tizen;

namespace GAssist
{
    internal class HtmlResponseParser
    {
        public static string ParseHtmlResponse(string html)
       {
          //  var positionAbs = "position: fixed;";
            var sugOld = "assistant_response";
            var sugNew = "assistant_response{opacity: 0.0 !important;}";
            var asisOld = "assistant-bar";
            var asisNew = "assistant-bar{ visibility: collapse;}";
            var shadow = "<div class=\"popout-shadow\" id=\"assistant-shadow\"></div>";
            var htmlOld = "html";
            var htmlNew = "html{ background-color: rgb(24, 24, 24);padding-right:50px;}";
            var popoutOld = "#popout{";
            var popoutNew = "#popout{ -moz-transform: scale(0.5, 0.5); zoom: 0.5; zoom: 50%;margin-top:100px;padding-left:0px;background-color: rgb(24, 24, 24);";
            var assistbarOld = "#carousel-container{";
            var assistbarNew = "#carousel-container{-moz-transform: scale(0.5, 0.5); zoom: 0.5; zoom: 100%;";
            var flex = "display:-webkit-flex;";
            var wrap = "display: -webkit-flex;\nheight: 260px;\nwidth: 110%;\n-webkit-flex-wrap: wrap;\n-webkit-flex-shrink: 1; scale = 1, maximum - scale = 0;";

            return html.Replace(htmlOld, htmlNew).Replace(popoutOld, popoutNew).Replace(assistbarOld, assistbarNew).Replace(asisOld, asisNew).Replace(sugOld, sugNew).Replace(flex, wrap).Replace(shadow, "");
        }

    }
}
