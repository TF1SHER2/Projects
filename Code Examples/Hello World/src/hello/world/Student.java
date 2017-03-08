/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hello.world;

/**
 *
 * @author Thomas
 */
public class Student
{

    

    /**
     * @return the name
     */
    public String getName()
    {
        return name;
    }

    /**
     * @param name the name to set
     */
    public void setName(String name)
    {
        this.name = name;
    }

    /**
     * @return the id
     */
    public int getId()
    {
        return id;
    }

    /**
     * @param id the id to set
     */
    public void setId(int id)
    {
        this.id = id;
    }

    /**
     * @return the year
     */
    public double getYear()
    {
        return year;
    }

    /**
     * @param year the year to set
     */
    public void setYear(double year)
    {
        this.year = year;
    }

    /**
     * @return the major
     */
    public String getMajor()
    {
        return major;
    }

    /**
     * @param major the major to set
     */
    public void setMajor(String major)
    {
        this.major = major;
    }
    
    private String name;
    private int id;
    private double year;
    private String major;
    
    public Student (String name, int id, double year, String major)
    {
        this.name = name;
        this.id = id;
        this.year = year;
        this.major = major;
    }
}
