using programa_mamalon_de_pagos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

public class EstudianteDAO
{
    private string connectionString;

    public EstudianteDAO(string dbPath)
    {
        connectionString = $"Data Source={dbPath};Version=3;";
    }

    public void InsertarEstudiante(Estudiante estudiante)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Verifica si el carnet ya existe antes de insertar.
            if (!ExisteCarnet(estudiante.Carnet))
            {
                string query = "INSERT INTO Estudiantes (Carnet, NombreCompleto, FechaDeNacimiento, CarreraGrado, Seccion, CorreoElectronico, Telefono, Jornada,Institucion,Facultad ) " +
                               "VALUES (@Carnet, @NombreCompleto, @FechaDeNacimiento, @CarreraGrado, @Seccion, @CorreoElectronico, @Telefono, @Jornada,@Institucion, @Facultad)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Carnet", estudiante.Carnet);
                    cmd.Parameters.AddWithValue("@NombreCompleto", estudiante.NombreCompleto);
                    cmd.Parameters.AddWithValue("@FechaDeNacimiento", estudiante.FechaDeNacimiento);
                    cmd.Parameters.AddWithValue("@CarreraGrado", estudiante.CarreraGrado);
                    cmd.Parameters.AddWithValue("@Seccion", estudiante.Seccion);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", estudiante.CorreoElectronico);
                    cmd.Parameters.AddWithValue("@Telefono", estudiante.Telefono);
                    cmd.Parameters.AddWithValue("@Jornada", estudiante.Jornada);
                    cmd.Parameters.AddWithValue("@Institucion", estudiante.Institucion);
                    cmd.Parameters.AddWithValue("@Institucion", estudiante.Facultad);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                throw new Exception("El carnet ya existe en la base de datos.");
            }
        }
    }

    public bool ExisteCarnet(int carnet)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT COUNT(*) FROM Estudiantes WHERE Carnet = @Carnet";

            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Carnet", carnet);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }
    }


}
