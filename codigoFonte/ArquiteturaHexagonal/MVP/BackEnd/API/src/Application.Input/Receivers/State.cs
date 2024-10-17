namespace API.Application.Input.Receivers
{
    public class State
    {
        public State(int statusCode, string message, object data)
        {
            StatusCode = statusCode;
            Message = message;
            Data = data;
        }

        public int StatusCode { get; private set; }
        public string Message { get; private set; }
        public object Data { get; private set; }

        public void SetData(object data)
        {
            this.Data = data;
        }
    }
}