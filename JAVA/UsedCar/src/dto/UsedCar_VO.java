package dto;

public class UsedCar_VO {
	
	private String company;
	private String name;
	private int price;
	private int	km;
	private String color;
	private String engine;
	private String accident;
	private String date;
	
	public UsedCar_VO(String company,String name,int price,int km,String color,
			String engine,String accident,String date) {
		this.company=company;
		this.name=name;
		this.price=price;
		this.km=km;
		this.color=color;
		this.engine=engine;
		this.accident=accident;
		this.date=date;
	}
	public void setCOMPANY(String company) {
		this.company=company;
	}
	public String getCOMPANY() {
		return company;
	}

	public void setNAME(String name) {
		this.name=name;
	}
	public String getNAME() {
		return name;
	}

	public void setPRICE(int price) {
		this.price=price;
	}
	public int getPRICE() {
		return price;
	}
	
	public void setKM(int km) {
		this.km=km;
	}
	public int getKM() {
		return km;
	}

	public void setCOLOR(String color) {
		this.color=color;
	}
	public String getCOLOR() {
		return color;
	}
	
	public void setENGINE(String engine) {
		this.engine=engine;
	}
	public String getENGINE() {
		return engine;
	}
	
	public void setACCIDENT(String accident) {
		this.accident=accident;
	}
	public String getACCIDENT() {
		return accident;
	}
	
	public void setDATE(String date) {
		this.date=date;
	}
	public String getDATE() {
		return date;
	}
}

