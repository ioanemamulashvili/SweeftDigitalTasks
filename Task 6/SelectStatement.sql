select Teacher.FirstName, Teacher.LastName from Teacher
inner join TeacherStudent on Teacher.TeacherID = TeacherStudent.TeacherID
inner join Student on TeacherStudent.StudentID = Student.StudentID
where Student.FirstName = N'გიორგი'