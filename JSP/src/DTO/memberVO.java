package DTO;

public class memberVO {
	private int user_number;
	private String id;
	private String pw;
	private String name;
	private String phone;

	public memberVO(int user_number, String id, String pw, String name, String phone) {
		this.user_number = user_number;
		this.id = id;
		this.pw = pw;
		this.name = name;
		this.phone = phone;
	}

	public void setUser_number(int user_number) {
		this.user_number = user_number;
	}

	public int getUser_number() {
		return user_number;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getID() {
		return id;
	}

	public void setPw(String pw) {
		this.pw = pw;
	}

	public String getPw() {
		return pw;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getName() {
		return name;
	}

	public void setPhone(String phone) {
		this.phone = phone;
	}

	public String getPhone() {
		return phone;
	}
}
