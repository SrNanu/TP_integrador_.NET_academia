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

                try
                {
                    Usuario_Controller.AgregarUsuario(usuario);
                    return Results.Ok(new { message = "Usuario creado exitosamente" });
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(ex.Message);
                }
            })
            .WithName("CrearUsuario");

            app.MapPut("/usuarios", (Usuario usuario) =>
            {

                try
                {
                    Usuario_Controller.ActualizarUsuario(usuario);
                    return Results.Ok(new { message = "Usuario actualizado exitosamente" });
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(ex.Message);
                }
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
                try
                {
                    Plan_Controller.CrearPlan(plan);
                    return Results.Ok(new { message = "Plan creado exitosamente" });
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(ex.Message);
                }
            })
            .WithName("CrearPlan");

            app.MapPut("/planes", (Plan plan) =>
            {
                try
                {
                    Plan_Controller.ActualizarPlan(plan);
                    return Results.Ok(new { message = "Plan actualizado exitosamente" });
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(ex.Message);
                }
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
                try
                {
                    Materia_Controller.CrearMateria(materia);
                    return Results.Ok(new { message = "Materia creada exitosamente" });
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(ex.Message);
                }
            })
            .WithName("CrearMateria");

            app.MapPut("/materias", (Materia materia) =>
            {
                try
                {
                    Materia_Controller.ActualizarMateria(materia);
                    return Results.Ok(new { message = "Materia actualizada exitosamente" });
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(ex.Message);
                }
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
                try
                {
                    Especialidad_Controller.CrearEspecialidad(especialidad);
                    return Results.Ok(new { message = "Especialidad creada exitosamente" });
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(ex.Message);
                }
            })
            .WithName("CrearEspecialidad");

            app.MapPut("/especialidades", (Especialidad especialidad) =>
            {
                try
                {
                    Especialidad_Controller.ActualizarEspecialidad(especialidad);
                    return Results.Ok(new { message = "Especialidad actualizada exitosamente" });
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(ex.Message);
                }
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
                try
                {
                    Curso_Controller.CrearCurso(curso);
                    return Results.Ok(new { message = "Curso creado exitosamente" });
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(ex.Message);
                }
            })
            .WithName("CrearCurso");

            app.MapPut("/cursos", (Curso curso) =>
            {
                try
                {
                    Curso_Controller.ActualizarCurso(curso);
                    return Results.Ok(new { message = "Curso actualizado exitosamente" });
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(ex.Message);
                }
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
                try
                {
                    Comision_Controller.ActualizarComision(comision);
                    return Results.Ok(new { message = "Comisión actualizada exitosamente" });
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(ex.Message);
                }
            })
            .WithName("ActualizarComision");

            app.MapDelete("/comisiones/{id}", (int id) =>
            {
                Comision_Controller.EliminarComision(id);
            })
            .WithName("EliminarComision");


            //CRUD Inscripciones

            app.MapGet("/inscipciones/{id}", (int id) =>
            {

                return AlumnoInscripcion_Controller.GetOneAlumnoInscripcion(id);
            })
            .WithName("GetOneInscripcion");

            app.MapGet("/inscipciones", () =>
            {

                return AlumnoInscripcion_Controller.GetAllAlumnoInscripcion();
            })
            .WithName("GetAllInscripciones");

            app.MapPost("/inscipciones", (AlumnoInscripcion alumnoinscripcion) =>
            {

                AlumnoInscripcion_Controller.CrearAlumnoInscripcion(alumnoinscripcion);
            })
            .WithName("CrearInscripcion");

            app.MapPut("/inscipciones", (AlumnoInscripcion alumnoinscripcion) =>
            {

                AlumnoInscripcion_Controller.ActualizarAlumnoInscripcion(alumnoinscripcion);
            })
            .WithName("ActualizarInscripcion");

            app.MapDelete("/inscipciones/{id}", (int id) =>
            {

                AlumnoInscripcion_Controller.EliminarAlumnoInscripcion(id);
            })
            .WithName("EliminarInscripcion");



            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
