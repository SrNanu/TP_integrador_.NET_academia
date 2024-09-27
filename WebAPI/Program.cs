namespace WebAPI
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddHttpLogging(o => { });
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            
            app.UseSwagger();
            app.UseSwaggerUI();
            //Falta configurar de manera correcta        
            app.UseHttpLogging();
            

            app.UseHttpsRedirection();


            //Actualmente estamos usando los objetos del Domain Model, deberiamos usar ViewModels o DTOs 

            app.MapGet("/usuarios/{legajo}", (int legajo) =>
            {


                return Usuario_Controller.LeerUsuario(legajo);
            })
            .WithName("LeerUsuario");
            //.WithOpenApi();

            app.MapGet("/usuarios", () =>
            {


                return Usuario_Controller.GetAll();
            })
            .WithName("GetAllUsuarios");
            //.WithOpenApi();

            app.MapPost("/usuarios", (Usuario usuario) =>
            {

                Usuario_Controller.CrearUsuario(usuario);
            })
            .WithName("CrearUsuario");
            //.WithOpenApi();

            app.MapPut("/usuarios", (Usuario usuario) =>
            {

                Usuario_Controller.ActualizarUsuario(usuario);
            })
            .WithName("ActualizarUsuario");
            //.WithOpenApi();

            app.MapDelete("/usuarios/{legajo}", (int legajo) =>
            {

                Usuario_Controller.EliminarUsuario(legajo);
            })
            .WithName("EliminarUsuario");
            //.WithOpenApi();


            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
