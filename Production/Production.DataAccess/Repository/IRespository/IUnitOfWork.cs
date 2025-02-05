﻿namespace Production.DataAccess.Repository.IRespository;

public interface IUnitOfWork
{
    ILineRepository Line {  get; }
    IUnitRepository Unit {  get; }
    ITypeLineRepository TypeLine { get; }
    IComputerProductionRepository Computer {  get; }
    void Save();
}