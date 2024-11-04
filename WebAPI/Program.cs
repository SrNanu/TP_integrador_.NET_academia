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


                return Usuario_Controller.GetOneUsuario(id);
            })
            .WithName("LeerUsuario");

            app.MapGet("/usuarios", () =>
            {


                return Usuario_Controller.GetAllUsuario();
            })
            .WithName("GetAllUsuarios");

            app.MapPost("/usuarios", (Usuario usuario) =>
            {

                Usuario_Controller.CrearUsuario(usuario);
            })
            .WithName("CrearUsuario");

            app.MapPut("/usuarios", (Usuario usuario) =>
            {

                Usuario_Controller.ActualizarUsuario(usuario);
            })
            .WithName("ActualizarUsuario");

            app.MapDelete("/usuarios/{id}", (int id) =>
            {

                Usuario_Controller.EliminarUsuario(id);
            })
            .WithName("EliminarUsuario");

            //CRUD PLAN 

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
