using Microsoft.AspNetCore.Authorization;

namespace DemoApp
{
  public static class Policies
  {
    public const string IsUser = "IsUser";
    public const string IsAdmin = "IsAdmin";

    public static AuthorizationPolicy IsUserPolicy()
    {
      return new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .RequireClaim("IsUser")
        .Build();
    }

    public static AuthorizationPolicy IsAdminPolicy()
    {
      return new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .RequireClaim("IsAdmin")
        .Build();
    }

  }
}
