﻿using AircraftPlantContracts.BindingModels;
using AircraftPlantContracts.BusinessLogicsContracts;
using AircraftPlantContracts.StoragesContracts;
using AircraftPlantContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftPlantBusinessLogic.BusinessLogics
{
	public class ClientLogic : IClientLogic
	{
        private readonly IClientStorage clientStorage;
        public ClientLogic(IClientStorage clientStorage)
        {
            this.clientStorage = clientStorage;
        }
        public List<ClientViewModel> Read(ClientBindingModel model)
        {
            if (model == null)
            {
                return clientStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ClientViewModel> { clientStorage.GetElement(model) };
            }
            return clientStorage.GetFilteredList(model);

        }
        public void CreateOrUpdate(ClientBindingModel model)
        {
            var element = clientStorage.GetElement(new ClientBindingModel { Email = model.Email });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть клиент с таким логином");
            }
            if (model.Id.HasValue)
            {
                clientStorage.Update(model);
            }
            else
            {
                clientStorage.Insert(model);
            }
        }
        public void Delete(ClientBindingModel model)
        {
            var element = clientStorage.GetElement(new ClientBindingModel { Id = model.Id });
            if (element == null)
            {
                throw new Exception("Клиент не найден");
            }
            clientStorage.Delete(model);
        }
    }
}
