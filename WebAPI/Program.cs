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


            //CRUD USUARIO

            app.MapGet("/usuarios/{id}", (int id) =>
            {


                return Usuario_Controller.GetOneUsuarioId(id);
            })
            .WithName("LeerUsuario");
            //.WithOpenApi();

            app.MapGet("/usuarios", () =>
            {


                return Usuario_Controller.GetAllUsuario();
            })
            .WithName("GetAllUsuarios");
            //.WithOpenApi();

            app.MapPost("/usuarios", (Usuario usuario) =>
            {

                Usuario_Controller.AgregarUsuario(usuario);
            })
            .WithName("CrearUsuario");
            //.WithOpenApi();

            app.MapPut("/usuarios", (Usuario usuario) =>
            {

                Usuario_Controller.ActualizarUsuario(usuario);
            })
            .WithName("ActualizarUsuario");
            //.WithOpenApi();

            app.MapDelete("/usuarios/{id}", (int id) =>
            {

                Usuario_Controller.EliminarUsuario(id);
            })
            .WithName("EliminarUsuario");
            //.WithOpenApi();

            //CRUD PLAN 

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
