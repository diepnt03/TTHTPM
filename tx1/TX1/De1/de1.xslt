<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
				xmlns:a="http://tempuri.org/de1.xsd"
>
	<xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<head>
				<title>quản lí sách</title>
			</head>
			<body>
				<table border="0">
					<tr>
						<td>THƯ VIỆN TỔNG HỢP</td>
						<td>
							<b>DANH SÁCH SÁCH XUẤT BẢN</b>
						</td>
					</tr>
				</table>
				<xsl:for-each select="a:thuvien/a:NXB">
					<p>
						Nhà xuất bản: <xsl:value-of select="a:tenNXB"/>
					</p>
					<table border ="2">
						<tr>
							<td>STT</td>
							<td>Mã sách</td>
							<td>Tên sách</td>
							<td>Tên tác giả</td>
							<td>Số trang</td>
							<td>Số lượng</td>
							<td>Ngày xuất bản</td>
							<td>Số tiền</td>
						</tr>
						<xsl:for-each select="a:sach">
							<tr>
								<td>
									<xsl:value-of select="position()"/>
								</td>
								<td>
									<xsl:value-of select="@masach"/>
								</td>
								<td>
									<xsl:value-of select="a:tensach"/>
								</td>
								<td>
									<xsl:value-of select="a:tacgia/a:hoten"/>
								</td>
								<td>
									<xsl:value-of select="a:sotrang"/>
								</td>
								<td>
									<xsl:value-of select="a:soluong"/>
								</td>
								<td>
									<xsl:value-of select="a:ngayxuatban"/>
								</td>
								<td>
									<xsl:value-of select="a:sotrang*1500"/>
								</td>								
							</tr>
						</xsl:for-each>
					</table>					
					<p>Tổng số tiền: <xsl:value-of select="sum(a:sach/a:sotrang)*1500"/></p>
				</xsl:for-each>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
