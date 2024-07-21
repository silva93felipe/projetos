namespace ApiPedidos.Dto;

public class HttpReponse {
    public string Message { get; private set; } = string.Empty;
    public object Data { get; private set; } = new List<object>();
    public HttpReponse(string message)
    {
        Message = message;
    }

    public HttpReponse(string message, object data)
    {
        Message = message;        
        Data = data;
    }
}