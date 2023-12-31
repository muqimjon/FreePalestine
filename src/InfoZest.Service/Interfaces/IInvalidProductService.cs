﻿using InfoZest.Service.DTOs.InvalidProducts;
using InfoZest.Service.Interfaces.Commons;

namespace InfoZest.Service.Interfaces;

public interface IInvalidProductService : IMainService<InvalidProductCreationDto, InvalidProductUpdateDto, InvalidProductResultDto> { }