using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppG2.Model;

namespace AppG2.Controller
{
    public class StudentService
    {
        /// <summary>
        /// Lấy thông tin sinh viên theo 'Mã sinh viên' từ File
        /// </summary>
        /// <param name="pathFileName">File lấy data</param>
        /// <param name="idStudent">Mã sinh viên</param>
        public static Student getStudent(string pathStudentFileName, string idStudent)
        {
            if (File.Exists(pathStudentFileName))
            {
                CultureInfo cultureInfo = CultureInfo.InvariantCulture;
                var lines = File.ReadAllLines(pathStudentFileName);
                foreach (var line in lines)
                {
                    var rs = line.Split(new char[] { '#' });
                    Student student = new Student
                    {
                        idStudent = rs[0],
                        firstName = rs[1],
                        lastName = rs[2],
                        gender = rs[3] == "Male" ? GENDER.Male : (rs[3] == "Female" ? GENDER.Female : GENDER.Other),
                        dateOfBirth = DateTime.ParseExact(rs[4], "yyyy-MM-dd", cultureInfo),
                        placeOfBirth = rs[5]
                    };
                    
                    if (student.idStudent == idStudent)
                    {
                        return student;
                    }
                }
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Lấy danh sách lịch sử học tập của sinh viên
        /// </summary>
        /// <param name="pathHistoryLeaningFileName">Link file</param>
        /// <param name="idStudent"><Mã sinh viên</param>
        /// <returns></returns>
        public static List<HistoryLearning> getHistoryLearning(string pathHistoryLeaningFileName, string idStudent)
        {
            if (File.Exists(pathHistoryLeaningFileName))
            {
                List<HistoryLearning> historyLearnings = new List<HistoryLearning>();
                var lines = File.ReadAllLines(pathHistoryLeaningFileName);
                foreach (var line in lines)
                {
                    if (!line.Equals(""))
                    {
                        var rs = line.Split(new char[] { '#' });
                        HistoryLearning historyLearning = new HistoryLearning
                        {
                            idHistoryLearning = rs[0],
                            yearFrom = int.Parse(rs[1]),
                            yearEnd = int.Parse(rs[2]),
                            address = rs[3],
                            idStudent = rs[4]
                        };
                        if (historyLearning.idStudent == idStudent)
                        {
                            historyLearnings.Add(historyLearning);
                        }
                    }
                }
                return historyLearnings;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Xóa lịch sử học tập
        /// </summary>
        /// <param name="pathHistoryLeaningFileName"></param>
        /// <param name="idHistoryLearning"></param>
        public static void deleteHistoryLearning(string pathHistoryLeaningFileName, string id_historyLearning)
        {
            if (File.Exists(pathHistoryLeaningFileName))
            {
                List<HistoryLearning> historyLearnings = new List<HistoryLearning>();
                var lines = File.ReadAllLines(pathHistoryLeaningFileName);
                foreach (var line in lines)
                {
                    var rs = line.Split(new char[] { '#' });
                    HistoryLearning historyLearning = new HistoryLearning
                    {
                        idHistoryLearning = rs[0],
                        yearFrom = int.Parse(rs[1]),
                        yearEnd = int.Parse(rs[2]),
                        address = rs[3],
                        idStudent = rs[4]
                    };
                    if (historyLearning.idHistoryLearning != id_historyLearning)
                    {
                        historyLearnings.Add(historyLearning);
                    }
                }

                List<string> lineWrites = new List<string>();

                foreach (var history in historyLearnings)
                {
                    string lineWrite = history.idHistoryLearning + "#"
                                      + history.yearFrom + "#"
                                      + history.yearEnd + "#"
                                      + history.address + "#"
                                      + history.idStudent;
                    lineWrites.Add(lineWrite);
                }
                File.WriteAllLines(pathHistoryLeaningFileName, lineWrites);
            }
        }

        public static void updateHistoryLearning(string pathHistoryLeaningFileName, string id, int yearFrom, int yearEnd, string address)
        {
            List<HistoryLearning> historyLearnings = new List<HistoryLearning>();
            var lines = File.ReadAllLines(pathHistoryLeaningFileName);
            foreach (var line in lines)
            {
                var rs = line.Split(new char[] { '#' });
                HistoryLearning historyLearning = new HistoryLearning
                {
                    idHistoryLearning = rs[0],
                    yearFrom = int.Parse(rs[1]),
                    yearEnd = int.Parse(rs[2]),
                    address = rs[3],
                    idStudent = rs[4]
                };
                historyLearnings.Add(historyLearning);
            }

            List<string> lineWrites = new List<string>();

            foreach (var history in historyLearnings)
            {
                if (history.idHistoryLearning == id)
                {
                    history.yearFrom = yearFrom;
                    history.yearEnd = yearEnd;
                    history.address = address;
                }

                string lineWrite = history.idHistoryLearning + "#"
                                  + history.yearFrom + "#"
                                  + history.yearEnd + "#"
                                  + history.address + "#"
                                  + history.idStudent;
                lineWrites.Add(lineWrite);
            }
            File.WriteAllLines(pathHistoryLeaningFileName, lineWrites);
        }

        public static void addNewHistoryLearning(string pathHistoryLeaningFileName, int yearFrom, int yearEnd, string address, string idStudent)
        {
            // Lấy danh sách HistoryLearning trong file
            List<HistoryLearning> historyLearnings = new List<HistoryLearning>();
            var lines = File.ReadAllLines(pathHistoryLeaningFileName);
            foreach (var line in lines)
            {
                var rs = line.Split(new char[] { '#' });
                HistoryLearning historyLearning = new HistoryLearning
                {
                    idHistoryLearning = rs[0],
                    yearFrom = int.Parse(rs[1]),
                    yearEnd = int.Parse(rs[2]),
                    address = rs[3],
                    idStudent = rs[4]
                };
                historyLearnings.Add(historyLearning);
            }

            // Lấy id lớn nhất
            var maxId = 0;
            foreach (var his in historyLearnings)
            {
                if (Int32.Parse(his.idHistoryLearning) > maxId)
                {
                    maxId = Int32.Parse(his.idHistoryLearning);
                }
            }

            // Tạo HistoryLearning mới
            var newHistoryLearning = new HistoryLearning();
            newHistoryLearning.idHistoryLearning = (maxId + 1).ToString();
            newHistoryLearning.yearFrom = yearFrom;
            newHistoryLearning.yearEnd = yearEnd;
            newHistoryLearning.address = address;
            newHistoryLearning.idStudent = idStudent;

            // Thêm HistoryLearning mới vào trong danh sách
            historyLearnings.Add(newHistoryLearning);

            // Ghi lại vào file
            List<string> lineWrites = new List<string>();
            foreach (var history in historyLearnings)
            {
                string lineWrite = history.idHistoryLearning + "#"
                                  + history.yearFrom + "#"
                                  + history.yearEnd + "#"
                                  + history.address + "#"
                                  + history.idStudent;
                lineWrites.Add(lineWrite);
            }
            File.WriteAllLines(pathHistoryLeaningFileName, lineWrites);
        }

        public static void updateInfoStudent(string pathStudentFileName, string id, string ho, string ten, GENDER gioiTinh, DateTime ngaySinh, string queQuan)
        {
            // Update info student
        }
    }
}
