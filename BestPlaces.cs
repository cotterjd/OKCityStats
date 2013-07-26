using System;
using System.IO;
using System.Net;

namespace HTMLParsing
{
	public class BestPlaces
	{
		
		protected string url = "http://www.bestplaces.net/";
		protected string prefix;
		protected string city;
		protected string keyword;
		protected int span;
		
		public BestPlaces (string city, string prefix, string keyword, int span)
		{
			this.span = span;
			this.city = city;
			url += prefix+"/city/oklahoma/"+city;
			this.keyword = keyword;
		}
	
		private string getHTML(string url, string keyword)
		{
			WebRequest webRequest = WebRequest.Create (url);
			Stream stream = webRequest.GetResponse ().GetResponseStream();
			StreamReader streamReader = new StreamReader(stream);
		
			string line="";

			while (line!=null)
			{
				line = streamReader.ReadLine();
				
				if (line.Contains (keyword))
					return line;
			}//end while
			stream.Close ();
			return "string not found";	
		}
		
		private string getInfo(string html, int span, string keyword)
		{	 
			int index = html.IndexOf(keyword); 
			string newString = html.Substring (index);
			
			string td = "<td>";
			int tdIndex = newString.IndexOf (td);
			
			if(newString.Substring (tdIndex+4, 1)=="<")//checks if <font> tag exists
			{	//creates string that begines with value
				string newerString = newString.Substring (tdIndex+19);
				int endOfValueIndex =  newerString.IndexOf ("<");
				return newerString.Substring(0, endOfValueIndex);
			}
			else
			{
				return newString.Substring (tdIndex+4, span);
			}
		}
		
		public override string ToString ()
		{
			 return getInfo(getHTML(url, keyword), span, keyword);
		} 
	}
}

