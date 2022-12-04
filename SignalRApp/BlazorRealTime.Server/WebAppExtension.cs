using BlazorRealTime.Server.Hubs;

namespace BlazorRealTime.Server
{
	public static class WebAppExtension
	{
		public static void AddConfig(this WebApplication app)
		{
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseCors("CorsPolicy");

			app.UseAuthorization();

			//app.MapControllers();

			app.UseRouting();

			app.UseEndpoints(endpoints => {
				endpoints.MapHub<NotificationHub>("/notificationhub");
				endpoints.MapControllers(); 
			});
		}
	}
}
