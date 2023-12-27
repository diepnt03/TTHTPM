<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<head>
				<title>Quản Lý SV</title>
			</head>
			<body>
				<h2>Students</h2>
				<table border="1">
					<tr bgcolor="#9acd32">
						<th>Roll No</th>
						<th>First Name</th>
						<th>Last Name</th>
						<th>Nick Name</th>
						<th>Mark</th>
					</tr>
					<tr>
						<xsl:apply-templates select="class/student" />
					</tr>
					
				</table>
			</body>
		</html>
    </xsl:template>
	<xsl:template match="class/student">
		<xsl:apply-templates select="@rollno" />
		<xsl:apply-templates select="firstname" />
		<xsl:apply-templates select="lastname" />
		<xsl:apply-templates select="nickname" />
		<xsl:apply-templates select="marks" />
		<br/>
	</xsl:template>
	<xsl:template match="@rollno">
		<span style="font-size:22px">
			<xsl:value-of select="."/>
		</span>
		<br/>
	</xsl:template>
	<xsl:template match="firstname">
		<span style="font-size:22px">
			<xsl:value-of select="."/>
		</span>
		<br/>
	</xsl:template>
	<xsl:template match="lastname">
		<span style="font-size:22px">
			<xsl:value-of select="."/>
		</span>
		<br/>
	</xsl:template>
	<xsl:template match="nickname">
		<span style="font-size:22px">
			<xsl:value-of select="."/>
		</span>
		<br/>
	</xsl:template>
	<xsl:template match="marks">
		<span style="font-size:22px">
			<xsl:value-of select="."/>
		</span>
		<br/>
	</xsl:template>
</xsl:stylesheet>
