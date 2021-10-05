using System;
namespace revisao
{
    public class Aluno
    {
        private String  nome;
        private float nota;
        private String mat; 
        public Aluno(String nome,float nota)
        {
            this.nome=nome;
            this.nota=nota;
        }
        public void setNota(float newNota)
        {
            this.nota = newNota;
        } 
        public float getNota()
        {
            return this.nota;
        } 
        public String getName () 
        {
            return this.nome;
        }
        public void setName(String name) 
        {
            this.nome = name;
        }
   

    }

}