using System;
using System.Collections.Generic;
using DIO.Series.interfaces;
namespace DIO.Series
{
  public class SerieRepositorio : IRepositorio<series>
  {
      private List<series> listaSerie = new List<series>();
    public void Atualiza(int id, series objeto)
    {
      listaSerie[id] = objeto;
    }

    public void Exclui(int id)
    {
      throw new NotImplementedException();
    }

    public void Insere(series entidade)
    {
      throw new NotImplementedException();
    }

    public List<series> Lista()
    {
      throw new NotImplementedException();
    }

    public int ProximosId()
    {
      throw new NotImplementedException();
    }

    public series RetornaPorId(int id)
    {
      throw new NotImplementedException();
    }
  }
}