namespace BlazorRealTime.Server
{
	public static class WebAppBuilderExtension
	{
		public static void AddServices(this WebApplicationBuilder builder)
		{
			builder.Services.AddControllers();
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			builder.Services.AddCors(options =>
			{
				options.AddPolicy("CorsPolicy", policy =>
				{
					policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
				});
			});

			builder.Services.AddSignalR();	
		}
	}
}
