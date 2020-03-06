namespace DeepShallowCopy
{
    public class ResponseControllers
    {
        private readonly Response response;

        public ResponseControllers()
        {
            this.response = new Response()
            {
                Number = 1,
                ResponseText = "Yes"
            };
        }

        public Response GetResponse()
        {
            return this.response;
        }
    }
}
