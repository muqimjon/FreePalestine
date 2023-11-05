﻿using InfoZest.Service.DTOs.Products;
using InfoZest.Service.Interfaces.Commons;

namespace InfoZest.Service.Interfaces;

public interface IProductService : IMainService<ProductCreateDto, ProductUpdateDto, ProductResultDto> { }