using Npgsql;
using System.Data;

namespace TestApp
{
    static class Connection
    {
        private static NpgsqlConnection Connect()
        {
            var connectionString = "Host=127.0.0.1:5432;Username=postgres;Password=postgres;Database=postgres";
            var conn = new NpgsqlConnection(connectionString);
            return conn;
        }

        public static DataTable FetchEmps()
        {
            var query = @"SELECT e.id, e.last_name, e.first_name, e.mid_name, d.dep, j.job, e.phone, e.address, e.salary, e.kpi
                        FROM employees AS e
                        LEFT JOIN(SELECT id, name AS dep FROM departments) AS d ON e.dep_id = d.id 
                        LEFT JOIN(SELECT id, name AS job FROM jobs) AS j ON e.job_id = j.id;";

            NpgsqlConnection conn = Connect(); 
            conn.Open();

            var cmd = new NpgsqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            DataTable data = new DataTable();
            data.Columns.Add("Id");
            data.Columns.Add("Прізвище");
            data.Columns.Add("Ім`я");
            data.Columns.Add("По Батькові");
            data.Columns.Add("Відділ");
            data.Columns.Add("Посада");
            data.Columns.Add("Телефон");
            data.Columns.Add("Адреса");
            data.Columns.Add("Заробітня плата");
            data.Columns.Add("Оцінка");

            while (reader.Read())
            {
                object[] list = new object[10];

                for (int i=0; i<10; i++)
                {
                    if (i == 8 || i == 0)
                    {
                        list[i] = reader.GetValue(i);
                    }
                    else
                    {
                        if (reader.IsDBNull(i))
                        {
                            list[i] = "";
                        }
                        else
                        {
                            list[i] = reader.GetString(i).ToString().Trim();
                        }
                    }
                }


                data.Rows.Add(list);
            }

            reader.Close();
            conn.Close();
            return data;
        }

        public static void UpdateEmp(Object[] emp)
        {
            var query = @"UPDATE employees
                        SET first_name=(@first_name), last_name=(@last_name), mid_name=(@mid_name), phone=(@phone), address=(@address), dep_id=(@dep_id), job_id=(@job_id), salary=(@salary), kpi=(@kpi)
                        WHERE id=(@id);";

            NpgsqlConnection conn = Connect();
            conn.Open();

            var cmd = new NpgsqlCommand(query, conn)
            {
                Parameters =
                {
                    new("id", Int32.Parse((string)emp[0])),
                    new("first_name", (string)emp[1]==string.Empty ? DBNull.Value : (string)emp[1]),
                    new("last_name", (string)emp[2]==string.Empty ? DBNull.Value : (string)emp[2]),
                    new("mid_name", (string)emp[3]==string.Empty ? DBNull.Value : (string)emp[3]),
                    new("phone", (string)emp[4]==string.Empty ? DBNull.Value : (string)emp[4]),
                    new("address", (string)emp[5]==string.Empty ? DBNull.Value : (string)emp[5]),
                    new("dep_id", (string)emp[6]==string.Empty ? DBNull.Value : Int32.Parse((string)emp[6])),
                    new("job_id", (string)emp[7]==string.Empty ? DBNull.Value : Int32.Parse((string)emp[7])),
                    new("salary", (string)emp[8]==string.Empty ? DBNull.Value : Int32.Parse((string)emp[8])),
                    new("kpi", (string)emp[9]==string.Empty ? DBNull.Value : (string)emp[9])
                }
            };
            cmd.ExecuteReader();

            conn.Close();
        }

        public static void DelEmp(Object[] emp)
        {
            var query = @"DELETE
                        FROM employees
                        WHERE id=(@id);";

            NpgsqlConnection conn = Connect();
            conn.Open();

            var cmd = new NpgsqlCommand(query, conn)
            {
                Parameters =
                {
                    new("id", Int32.Parse((string)emp[0])),
                }
            };
            cmd.ExecuteReader();

            conn.Close();
        }

        public static int  AddEmp(Object[] emp)
        {
            var query = @"INSERT INTO employees(first_name, last_name, mid_name, phone, address, dep_id, job_id, salary, kpi)
                        VALUES ((@first_name), (@last_name), (@mid_name), (@phone), (@address), (@dep_id), (@job_id), (@salary), (@kpi))
                        RETURNING id";

            NpgsqlConnection conn = Connect();
            conn.Open();

            var cmd = new NpgsqlCommand(query, conn)
            {
                Parameters =
                {
                    new("first_name", (string)emp[1]==string.Empty ? DBNull.Value : (string)emp[1]),
                    new("last_name", (string)emp[2]==string.Empty ? DBNull.Value : (string)emp[2]),
                    new("mid_name", (string)emp[3]==string.Empty ? DBNull.Value : (string)emp[3]),
                    new("phone", (string)emp[4]==string.Empty ? DBNull.Value : (string)emp[4]),
                    new("address", (string)emp[5]==string.Empty ? DBNull.Value : (string)emp[5]),
                    new("dep_id", (string)emp[6]==string.Empty ? DBNull.Value : Int32.Parse((string)emp[6])),
                    new("job_id", (string)emp[7]==string.Empty ? DBNull.Value : Int32.Parse((string)emp[7])),
                    new("salary", (string)emp[8]==string.Empty ? DBNull.Value : Int32.Parse((string)emp[8])),
                    new("kpi", (string)emp[9]==string.Empty ? DBNull.Value : (string)emp[9])
                }
            };

            var reader = cmd.ExecuteReader();
            reader.Read();
            int id = reader.GetInt32(0);

            reader.Close();
            conn.Close();
            return id;
        }

        internal static object[] GetDep(int id)
        {
            var query = @"SELECT id, name
                        FROM derartments
                        WHERE id = (@id);";

            NpgsqlConnection conn = Connect();
            conn.Open();

            var cmd = new NpgsqlCommand(query, conn)
            {
                Parameters =
                {
                    new("id", id)
                }
            };
            var reader = cmd.ExecuteReader();

            Object[] dep = new Object[2];
            while (reader.Read())
            {
                dep[0] = reader.GetValue(0);
                dep[1] = reader.GetString(1);
            }

            reader.Close();
            conn.Close();
            return dep;
        }

        public static object[] GetEmp(int id)
        {
            var query = @"SELECT id, first_name, last_name, mid_name, phone, address, dep_id, job_id, salary, kpi
                        FROM employees
                        WHERE id = (@id);";

            NpgsqlConnection conn = Connect();
            conn.Open();

            var cmd = new NpgsqlCommand(query, conn)
            {
                Parameters =
                {
                    new("id", id)
                }
            };
            var reader = cmd.ExecuteReader();

            object[] emp = new object[10];
            while (reader.Read())
            {
                emp[0] = reader.GetValue(0);

                for (int i = 0; i < 10; i++)
                {
                    if (i == 8 || i == 0 || i == 6 || i == 7)
                    {
                        emp[i] = reader.GetValue(i);
                    }
                    else
                    {
                        if (reader.IsDBNull(i))
                        {
                            emp[i] = "";
                        }
                        else
                        {
                            emp[i] = reader.GetString(i).ToString().Trim();
                        }
                    }
                }
            }

            reader.Close();
            conn.Close();
            return emp;
        }

        public static int AddDep(Object[] dep)
        {
            var query = @"INSERT INTO departments(name)
                        VALUES ((@name))
                        RETURNING id";

            NpgsqlConnection conn = Connect();
            conn.Open();

            var cmd = new NpgsqlCommand(query, conn)
            {
                Parameters =
                {
                    new("name", (string)dep[1]==string.Empty ? DBNull.Value : (string)dep[1]),
                }
            };

            var reader = cmd.ExecuteReader();
            reader.Read();
            int id = reader.GetInt32(0);

            reader.Close();
            conn.Close();
            return id;
        }

        public static void UpdateDep(Object[] dep)
        {
            var query = @"UPDATE employees
                        SET name=(@name)
                        WHERE id=(@id);";

            NpgsqlConnection conn = Connect();
            conn.Open();

            var cmd = new NpgsqlCommand(query, conn)
            {
                Parameters =
                {
                    new("id", Int32.Parse((string)dep[0])),
                    new("name", (string)dep[1]==string.Empty ? DBNull.Value : (string)dep[1]),
                }
            };
            cmd.ExecuteReader();

            conn.Close();
        }

        public static void DelDep(Object[] dep)
        {
            var query = @"DELETE
                        FROM departments
                        WHERE id=(@id);";

            NpgsqlConnection conn = Connect();
            conn.Open();

            var cmd = new NpgsqlCommand(query, conn)
            {
                Parameters =
                {
                    new("id", Int32.Parse((string)dep[0])),
                }
            };
            cmd.ExecuteReader();

            conn.Close();
        }

        public static DataTable FetchDeps()
        {
            var query = @"SELECT id, name
                        FROM departments;";

            NpgsqlConnection conn = Connect();
            conn.Open();

            var cmd = new NpgsqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            DataTable data = new DataTable();
            data.Columns.Add("Id");
            data.Columns.Add("Вдділ");

            while (reader.Read())
            {
                Object[] list = new Object[2];
                list[0] = reader.GetValue(0);
                list[1] = reader.GetString(1);

                data.Rows.Add(list);
            }

            reader.Close();
            conn.Close();
            return data;
        }

        public static DataTable FetchJobs()
        {
            var query = @"SELECT id, name
                        FROM jobs;";

            NpgsqlConnection conn = Connect();
            conn.Open();

            var cmd = new NpgsqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            DataTable data = new DataTable();
            data.Columns.Add("Id");
            data.Columns.Add("Посада");

            while (reader.Read())
            {
                Object[] list = new Object[2];
                list[0] = reader.GetValue(0);
                list[1] = reader.GetString(1);

                data.Rows.Add(list);
            }

            reader.Close();
            conn.Close();
            return data;
        }
    }
}
