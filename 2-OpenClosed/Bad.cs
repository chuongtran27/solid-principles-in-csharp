namespace SolidPrinciples.OpenClosed.Bad
{
    abstract class AdapterBase
    {
        protected string Name;

        public string GetName()
        {
            return Name;
        }
    }

    class AjaxAdapter : AdapterBase
    {
        public AjaxAdapter()
        {
            Name = "ajaxAdapter";
        }
    }

    class HTTPAdapter : AdapterBase
    {
        public HTTPAdapter()
        {
            Name = "httpAdapter";
        }
    }

    class HttpRequester : AdapterBase
    {
        private readonly AdapterBase Adapter;

        public HttpRequester(AdapterBase adapter)
        {
            Adapter = adapter;
        }

        // (Bad) Modify existing code to implement request calling methods for each adapter.
        public string Fetch(string url)
        {
            var adapterName = Adapter.GetName();
            switch (adapterName)
            {
                case "ajaxAdapter":
                    return MakeAjaxCall(url);
                case "httpAdapter":
                    return MakeHttpCall(url);
                default:
                    return null;
            }
        }

        private string MakeAjaxCall(string url) => "AjaxResult";
        private string MakeHttpCall(string url) => "HTTPResult";
    }
}