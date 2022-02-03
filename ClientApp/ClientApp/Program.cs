using HTTP_APi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
        }
        private async static Task GetListOfStudents()
        {
            using var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://localhost:44300/students/");
            response.EnsureSuccessStatusCode();
            Stream stream = await response.Content.ReadAsStreamAsync();
            List<Student> students = await JsonSerializer.DeserializeAsync<List<Student>>(stream);
            PrintListOfStudents(students);
        }
        private async static Task GetStudent(int id)
        {
            using var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://localhost:44300/students/{id}");
            response.EnsureSuccessStatusCode();
            Stream stream = await response.Content.ReadAsStreamAsync();
            Student student = await JsonSerializer.DeserializeAsync<Student>(stream);
            PrintStudent(student);
        }
        private static void PrintListOfStudents(List<Student> students)
        {
            for(int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{students[i].Id} - {students[i].FirstName} {students[i].LastName} {students[i].MiddleName}");
            }
        }
        private static void PrintStudent(Student student)
        {
            Console.WriteLine($"{student.Id} - {student.FirstName} {student.LastName} {student.MiddleName}");
        }

        private async static Task PostNewTopic(string NameOfTopic, string Name)
        {
            using var client = new HttpClient();
            NewTopicDTO topic = new NewTopicDTO(NameOfTopic, Name);
            HttpContent content = JsonContent.Create(topic);
            HttpResponseMessage response = await client.PostAsync("https://localhost:44300/Forum/", content);
            response.EnsureSuccessStatusCode();
        }
    }
}
