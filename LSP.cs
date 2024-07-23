

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
			new OnlineCourse { CourseId = 1, Title = "Online C# Course" },


			new OfflineCourse { CourseId = 2, Title = "Offline C# Course" },
			new HybridCourse { CourseId = 3, Title = "Hybrid C# Course" }
		};

			Student student = new Student { StudentId = 1, Name = "John Doe" };

			foreach (var course in courses)
			{
				course.Subscribe(student);
				Console.WriteLine(course.GetDetails());
			}
		}
	}
