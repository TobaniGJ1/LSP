

namespace LSP
{
	public abstract class Course
	{
		public int CourseId { get; set; }

		public string Title { get; set; }

		public abstract void Subscribe(Student std);

		public abstract string GetDetails();
	}

	public class OnlineCourse : Course
	{
		public override void Subscribe(Student std)
		{
		}

		public override string GetDetails()
		{
			return $"Online Course: {Title}";
		}
	}

	public class OfflineCourse : Course
	{
		public override void Subscribe(Student std)
		{
		}

		public override string GetDetails()
		{
			return $"Offline Course: {Title}";
		}
	}

	public class HybridCourse : Course
	{
		public override void Subscribe(Student std)
		{
		}

		public override string GetDetails()
		{
			return $"Hybrid Course: {Title}";
		}
	}


	public class Student
	{

		public int StudentId { get; set; }

		public string Name { get; set; }
	}


	public class Program
	{
		public static void Main(string[] args)
		{
			List<Course> courses = new List<Course>
		{
			new OnlineCourse { CourseId = 1, Title = "Curso de Programación en Línea"},


			new OfflineCourse { CourseId = 2, Title = "Curso de Programación Presencial" },
			new HybridCourse { CourseId = 3, Title = "Curso de Programación Híbrido" }
		};



			Student student = new Student { StudentId = 1, Name = "Tobani Gonzalez" };

			foreach (var course in courses)
			{
				course.Subscribe(student);
				Console.WriteLine(course.GetDetails());
			}
		}
	}
