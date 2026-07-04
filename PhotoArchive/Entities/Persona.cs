using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoArchive.Core;


namespace PhotoArchive.Entities;

/// <summary>
/// Classe Persona
/// </summary>
internal class Persona
{
    protected int _id;
    protected string _name;
    protected string _surname;
    protected string _gender;
    protected DateTime _date_birth;
    protected DateTime _date_death;

    protected Persona(
        int ID,
        string name,
        string surname,
        string gender,
        DateTime date_birth,
        DateTime date_death)
    {
        _id = ID;
        _name = name;
        _surname = surname;
        _gender = gender;
        _date_birth = date_birth;
        _date_death = date_death;
    }

}