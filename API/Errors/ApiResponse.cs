namespace API.Errors
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        private static string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Bad request, algo ha ido mal con la petición",
                401 => "No estas authorizado para recibir este contenido",
                404 => "Recurso no encontrado",
                500 => "Error del lado del servidor!!, F",
                _ => null
            };
        }
    }
}