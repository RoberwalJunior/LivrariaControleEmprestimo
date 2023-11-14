﻿namespace LivrariaControleEmprestimo.Domain.Interfaces;

public interface IQuery<T> where T : class
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(int id);
}
