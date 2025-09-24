using Microsoft.AspNetCore.Http.HttpResults;
using TimetableDesigner.API.Services.Authentication.DTO;

namespace TimetableDesigner.API.Services.Authentication.API;

public static class Endpoints
{
    public static IEndpointRouteBuilder MapEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/register", Register)
           .WithName("Register");
        app.MapPost("/authenticate_password", AuthenticatePassword)
           .WithName("AuthenticatePassword");
        app.MapPost("/authenticate_token", AuthenticateToken)
           .WithName("AuthenticateToken");

        return app;
    }

    public static async Task<Results<Ok<AuthenticateResponse>, ProblemHttpResult>> Register(RegisterRequest request)
    {
        return null;
    }

    public static async Task<Results<Ok<AuthenticateResponse>, ProblemHttpResult>> AuthenticatePassword(AuthenticatePasswordRequest request)
    {
        return null;
    }
    
    public static async Task<Results<Ok<AuthenticateResponse>, ProblemHttpResult>> AuthenticateToken(AuthenticateTokenRequest request)
    {
        return null;
    }
}