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

            app.MapGet("/usuarios", () =>
            {


                return Usuario_Controller.GetAllUsuario();
            })
            .WithName("GetAllUsuarios");

            app.MapPost("/usuarios", (Usuario usuario) =>
            {

                Usuario_Controller.AgregarUsuario(usuario);
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

            app.MapGet("/planes/{id}", (int id) =>
            {
                return Plan_Controller.GetOnePlan(id);
            })
            .WithName("LeerPlan");

            app.MapGet("/planes", () =>
            {
                return Plan_Controller.GetAllPlan();
            })
            .WithName("GetAllPlanes");

            app.MapPost("/planes", (Plan plan) =>
            {
                Plan_Controller.CrearPlan(plan);
            })
            .WithName("CrearPlan");

            app.MapPut("/planes", (Plan plan) =>
            {
                Plan_Controller.ActualizarPlan(plan);
            })
            .WithName("ActualizarPlan");

            app.MapDelete("/planes/{id}", (int id) =>
            {
                Plan_Controller.EliminarPlan(id);
            })
            .WithName("EliminarPlan");

            // CRUD MATERIA

            app.MapGet("/materias/{id}", (int id) =>
            {
                return Materia_Controller.GetOneMateria(id);
            })
            .WithName("LeerMateria");

            app.MapGet("/materias", () =>
            {
                return Materia_Controller.GetAllMateria();
            })
            .WithName("GetAllMaterias");

            app.MapPost("/materias", (Materia materia) =>
            {
                Materia_Controller.CrearMateria(materia);
            })
            .WithName("CrearMateria");

            app.MapPut("/materias", (Materia materia) =>
            {
                Materia_Controller.ActualizarMateria(materia);
            })
            .WithName("ActualizarMateria");

            app.MapDelete("/materias/{id}", (int id) =>
            {
                Materia_Controller.EliminarMateria(id);
            })
            .WithName("EliminarMateria");

            // CRUD ESPECIALIDAD

            app.MapGet("/especialidades/{id}", (int id) =>
            {
                return Especialidad_Controller.GetOneEspecialidad(id);
            })
            .WithName("LeerEspecialidad");

            app.MapGet("/especialidades", () =>
            {
                return Especialidad_Controller.GetAllEspecialidad();
            })
            .WithName("GetAllEspecialidades");

            app.MapPost("/especialidades", (Especialidad especialidad) =>
            {
                Especialidad_Controller.CrearEspecialidad(especialidad);
            })
            .WithName("CrearEspecialidad");

            app.MapPut("/especialidades", (Especialidad especialidad) =>
            {
                Especialidad_Controller.ActualizarEspecialidad(especialidad);
            })
            .WithName("ActualizarEspecialidad");

            app.MapDelete("/especialidades/{id}", (int id) =>
            {
                Especialidad_Controller.EliminarEspecialidad(id);
            })
            .WithName("EliminarEspecialidad");

            // CRUD CURSO

            app.MapGet("/cursos/{id}", (int id) =>
            {
                return Curso_Controller.GetOneCurso(id);
            })
            .WithName("LeerCurso");

            app.MapGet("/cursos", () =>
            {
                return Curso_Controller.GetAllCurso();
            })
            .WithName("GetAllCursos");

            app.MapPost("/cursos", (Curso curso) =>
            {
                Curso_Controller.CrearCurso(curso);
            })
            .WithName("CrearCurso");

            app.MapPut("/cursos", (Curso curso) =>
            {
                Curso_Controller.ActualizarCurso(curso);
            })
            .WithName("ActualizarCurso");

            app.MapDelete("/cursos/{id}", (int id) =>
            {
                Curso_Controller.EliminarCurso(id);
            })
            .WithName("EliminarCurso");

            // CRUD COMISIÓN

            app.MapGet("/comisiones/{id}", (int id) =>
            {
                return Comision_Controller.GetOneComision(id);
            })
            .WithName("LeerComision");

            app.MapGet("/comisiones", () =>
            {
                return Comision_Controller.GetAllComision();
            })
            .WithName("GetAllComisiones");

            app.MapPost("/comisiones", (Comision comision) =>
            {
                
                try { 
                Comision_Controller.CrearComision(comision);
                    return Results.Ok(new { message = "Comisión creada exitosamente" });
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(ex.Message);
                }

            })
            .WithName("CrearComision");

            app.MapPut("/comisiones", (Comision comision) =>
            {
                Comision_Controller.ActualizarComision(comision);
            })
            .WithName("ActualizarComision");

            app.MapDelete("/comisiones/{id}", (int id) =>
            {
                Comision_Controller.EliminarComision(id);
            })
            .WithName("EliminarComision");


            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
