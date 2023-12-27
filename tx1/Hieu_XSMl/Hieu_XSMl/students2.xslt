<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="class">
		<html>
			<head>
				<title>Lop Học</title>
			</head>
			<body>
				<h2>Danh sách sinh viên</h2>
				<table border="1" cellpadding="2">
					<tr>
						<th>Thu tu</th>
						<th>FirstName</th>
						<th>LastName</th>
						<th>Marks</th>
						<th>Xếp loại</th>
					</tr>
					<xsl:apply-templates select="student"/>
				</table>
				<br/>
				So luong sinh vien : <xsl:value-of select="count(student/firstname)"/>
				<br/>
				Tong diem cua sinh vien: 
					<xsl:value-of select="sum(student/marks)"/>
			</body>
		</html>
    </xsl:template>
	<xsl:template match="student">
		<tr>
			<td>
				<xsl:number value="position()" format="1"/>
			</td>
			<td>
				<xsl:value-of select="firstname"/>
			</td>
			<td>
				<xsl:value-of select="lastname"/>
			</td>
			<td>
				<xsl:value-of select="marks"/>
			</td>
			<td>
				<xsl:choose>
					<xsl:when test="marks >= 8">Gioi</xsl:when>
					<xsl:when test="marks >= 7">Kha</xsl:when>
					<xsl:when test="marks >= 5">Trung Bình</xsl:when>
					<xsl:otherwise>Kém</xsl:otherwise>
				</xsl:choose>
			</td>
		</tr>
	</xsl:template>
</xsl:stylesheet>
