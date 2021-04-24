using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarByBrandId(int brandId);
        IDataResult<List<Car>> GetCarByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetAllCarDetailByCarId(int colorId);
        IDataResult<Car> Get(int id);
        IDataResult<List<CarDetailDto>> GetDtoBrandAndColorId(int brandId, int colorId);
    }
}
