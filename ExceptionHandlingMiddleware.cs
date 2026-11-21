namespace StudentManagementAPI.Middleware
{
    // This middleware catches any error and sends a simple message
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                // show the real error in console
                Console.WriteLine("Error: " + ex.Message);

                // send clean message to the client
                context.Response.StatusCode = 500;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(
                    "{\"status\": 500, \"message\": \"Something went wrong on the server.\"}");
            }
        }
    }
}
