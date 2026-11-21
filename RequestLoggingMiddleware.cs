namespace StudentManagementAPI.Middleware
{
    // This middleware prints every request and response in the console
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            DateTime start = DateTime.Now;

            // before the request goes to controller
            Console.WriteLine("Request -> " + context.Request.Method + " " + context.Request.Path);

            // call the next middleware
            await _next(context);

            // after the response is ready
            TimeSpan time = DateTime.Now - start;
            Console.WriteLine("Response <- " + context.Response.StatusCode + " (" + (int)time.TotalMilliseconds + " ms)");
        }
    }
}
