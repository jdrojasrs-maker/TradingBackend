using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Pacagroup.Trade.Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Trade.Application.UseCases.Features.Orders.Queries.GetOrder
{
    public class GetOrderHandler : IRequestHandler<GetOrderQuery, GetOrderResponseDto>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public GetOrderHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public async Task<GetOrderResponseDto> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            var order = await _applicationDbContext.Orders.FirstOrDefaultAsync(o => o.Id.Equals(request.Id), cancellationToken);
            return _mapper.Map<GetOrderResponseDto>(order);
        }
    }
}
