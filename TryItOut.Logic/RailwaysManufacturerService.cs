using System;
using TryItOut.CommonInterfaces;
using TryItOut.Domain.Models;
using TryItOut.Service.DTOs;
using TryItOut.Service.Interfaces;

namespace TryItOut.Logic
{
    public class RailwaysmanufacturerService : IRailwaysManufacturService
    {
        IRailwaysManufacturerCRUD repo = null;

        public RailwaysmanufacturerService(IRailwaysManufacturerCRUD repo)
        {
            this.repo = repo;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public RailwaysManufacturerDTO Read(int id)
        {
            RailwaysManufacturerDTO dto = new RailwaysManufacturerDTO();
            var data = Read().listOfManufacturers.Find( x => x.ManufacturerId == id);

            /* map to dto */

            dto.ManufacturerId = data.ManufacturerId;
            dto.Name = data.Name;

            return dto;
        }

        public RailwaysManufacturersDTO Read()
        {
            RailwaysManufacturersDTO dto = new RailwaysManufacturersDTO();
            var locoClassifications = repo.Read();

            /* transfer from domain model to dto */

            if (locoClassifications.Count > 0)
            {
                foreach (var man in locoClassifications)
                {
                    dto.listOfManufacturers.Add(new RailwaysManufacturerDTO()
                    {
                        ManufacturerId = man.ManufacturerId,
                        Name = man.Name
                    });
                }

                dto.hasManufacturers = true;
                dto.count = dto.listOfManufacturers.Count;
            }
            else
            {
                dto.hasManufacturers = false;
            }

            return dto;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

    }
}
