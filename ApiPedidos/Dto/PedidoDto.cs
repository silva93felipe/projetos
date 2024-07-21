namespace ApiPedidos.Dto;

public record PedidoDto(List<PeditoItemDto> Items);
public record PeditoItemDto(int ProjetoId, int Quantidade);