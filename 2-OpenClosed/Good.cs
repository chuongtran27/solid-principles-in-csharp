namespace SolidPrinciples.OpenClosed.Good
{
    interface IAdapter
    {
        string Fetch(string url);
    }

    // (Good) Each class implement their own Fetch() method
    class AjaxAdapter : IAdapter
    {
        public string Fetch(string url) => "AjaxResult";
    }

    class NodeAdapter : IAdapter
    {
        public string Fetch(string url) => "HTTPResult";
    }

    class HttpRequester
    {
        private readonly IAdapter Adapter;

        public HttpRequester(IAdapter adapter)
        {
            Adapter = adapter;
        }

        // Low-level module just need to call Fetch() method
        public string Fetch(string url)
        {
            return Adapter.Fetch(url);
        }
    }

}