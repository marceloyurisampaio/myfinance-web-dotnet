﻿namespace myfinance_web_dotnet_domain.Entities;

public class Transacao
{
  public int? Id { get; set; }

  public string Historico { get; set; }

  public DateTime Data { get; set; }

  public decimal Valor { get; set; }
}
