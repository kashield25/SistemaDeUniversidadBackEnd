﻿using SistemaUniversidad.BackEnd.API.Models;
using SistemaUniversidad.BackEnd.API.UnitOfWork;

namespace SistemaUniversidad.BackEnd.API.Services.Interfaces
{
    public class CursoEnAulaService : ICursoEnAulaService
    {
        private IUnitOfWork BD;
        public CursoEnAulaService(IUnitOfWork unitOfWork)
        {
            BD = unitOfWork;
        }
        public void Actualizar(CursoEnAula model)
        {
            using (var bd = BD.Conectar())
            {
                bd.Repositories.CursoEnAulaRepository.Actualizar(model);

                bd.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (var bd = BD.Conectar())
            {
                bd.Repositories.CursoEnAulaRepository.Eliminar(id);

                bd.SaveChanges();
            }
        }

        public void Insertar(CursoEnAula model)
        {
            using (var bd = BD.Conectar())
            {
                bd.Repositories.CursoEnAulaRepository.Insertar(model);

                bd.SaveChanges();
            }
        }

        public CursoEnAula SeleccionarPorId(int id)
        {
            CursoEnAula CursoEnaulaSeleccionado = new();

            using (var bd = BD.Conectar())
            {
                CursoEnaulaSeleccionado = bd.Repositories.CursoEnAulaRepository.SeleccionarPorId(id);

                bd.SaveChanges();
            }

            return CursoEnaulaSeleccionado;
        }

        public List<CursoEnAula> SeleccionarTodos()
        {
            List<CursoEnAula> listaTodosLosCursoEnaula;

            using (var bd = BD.Conectar())
            {
                listaTodosLosCursoEnaula = bd.Repositories.CursoEnAulaRepository.SeleccionarTodos();

                bd.SaveChanges();
            }

            return listaTodosLosCursoEnaula;
        }
    }
}
