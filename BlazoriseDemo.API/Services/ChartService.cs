using BlazoriseDemo.API.Models;
using BlazoriseDemo.API.Utils;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoriseDemo.API.Services
{
    public interface IChartService
    {
        List<DataItem> GetData();
        ConvertModel GetDataList(int skip);
    }
    public class ChartService : IChartService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ChartService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public List<DataItem> GetData()
        {
            return new List<DataItem>
            {
                new DataItem{ Lable="Red",Value= 150},
                new DataItem{ Lable="Green",Value= 174},
                new DataItem{ Lable="Yellow",Value= 90},
                new DataItem{ Lable="Black",Value= 180},
                new DataItem{ Lable="White",Value= 100},
                new DataItem{ Lable="Blue",Value= 250}
            };
        }
        public ConvertModel GetDataList(int skip)
        {
            var path = Path.Combine(_hostingEnvironment.WebRootPath + @"\CTGDataset.csv");
            var record = new ConvertModel();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
                PrepareHeaderForMatch = args => args.Header.ToLower(),

            };

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, config))
            {
                record = csv.GetRecords<CSVModel>().Select(p => new ConvertModel
                {
                    MHR = p.MHR,
                    FHR1 = p.FHR1,
                    FHR2 = p.FHR2,
                    timestamp = p.timestamp.TimeStampToDateTime()
                }).Skip(skip).Take(1).SingleOrDefault();
            }

            return record;
        }
    }
}
