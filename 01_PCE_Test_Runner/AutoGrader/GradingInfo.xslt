<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<!-- The exercise name to put at the top of the document -->
	<xsl:template name="LessonNumber">PCE 06</xsl:template>


  <!-- This is for Categories that have a name, but the name doesn't match anything.
			This should never happen 'in production', and will be flagged as an error 
			during the output phase -->
  <xsl:template match="Category[@name!='']" priority="-10">
    <xsl:call-template name="GenerateFailedTest">
      <xsl:with-param name="CategoryName">
        <xsl:value-of select="$Missing_Category"/>
      </xsl:with-param>
      <xsl:with-param name="NodeList" select="." />
      <xsl:with-param name="PointPenalty" select="-1" />
      <xsl:with-param name="Explanation">
        Unable to find a grading category for <xsl:value-of select="@name"/>
      </xsl:with-param>
    </xsl:call-template>
  </xsl:template>

  <xsl:template match="Category[@name='PrintEvenNumbers_Recursively']">
		<xsl:call-template name="GenerateFailedTest">
			<xsl:with-param name="CategoryName">
				<xsl:value-of select="@name"/>
			</xsl:with-param>
			<xsl:with-param name="NodeList" select="." />
			<xsl:with-param name="PointPenalty" select="-3" />
			<xsl:with-param name="Explanation">There is a problem with your "Printing Even Numbers Recursively" exercise. 
				This test worked by examining the output of your method, NOT by verifying the method call transcript </xsl:with-param>
		</xsl:call-template>
	</xsl:template>
	
	<xsl:template match="Category[@name='PrintEvenNumbers_Recursively_Verified']">
		<xsl:call-template name="GenerateFailedTest">
			<xsl:with-param name="CategoryName">
				<xsl:value-of select="@name"/>
			</xsl:with-param>
			<xsl:with-param name="NodeList" select="." />
			<xsl:with-param name="PointPenalty" select="-1" />
			<xsl:with-param name="Explanation">
				There is a problem with your "Printing Even Numbers Recursively" exercise.
				This test worked by verifying the method call transcript, NOT by examining the output of your method.
			</xsl:with-param>
		</xsl:call-template>
	</xsl:template>

	<xsl:template match="Category[@name='Recursive Multiplication Positives']">
		<xsl:call-template name="GenerateFailedTest">
			<xsl:with-param name="CategoryName">
				<xsl:value-of select="@name"/>
			</xsl:with-param>
			<xsl:with-param name="NodeList" select="." />
			<xsl:with-param name="PointPenalty" select="-2" />
			<xsl:with-param name="Explanation">Your recursive multiplication isn't multiplying two positive numbers together correctly</xsl:with-param>
		</xsl:call-template>
	</xsl:template>

	<xsl:template match="Category[@name='Recursive Multiplication Pos Neg']">
		<xsl:call-template name="GenerateFailedTest">
			<xsl:with-param name="CategoryName">
				<xsl:value-of select="@name"/>
			</xsl:with-param>
			<xsl:with-param name="NodeList" select="." />
			<xsl:with-param name="PointPenalty" select="-1" />
			<xsl:with-param name="Explanation">Your recursive multiplication isn't multiplying a positive number by a negative number (in that order) together correctly</xsl:with-param>
		</xsl:call-template>
	</xsl:template>
	<xsl:template match="Category[@name='Recursive Multiplication Neg Pos']">
		<xsl:call-template name="GenerateFailedTest">
			<xsl:with-param name="CategoryName">
				<xsl:value-of select="@name"/>
			</xsl:with-param>
			<xsl:with-param name="NodeList" select="." />
			<xsl:with-param name="PointPenalty" select="-1" />
			<xsl:with-param name="Explanation">Your recursive multiplication isn't multiplying a negative number by a positive number (in that order) together correctly</xsl:with-param>
		</xsl:call-template>
	</xsl:template>

	<xsl:template match="Category[@name='Recursive Multiplication Neg Neg']">
		<xsl:call-template name="GenerateFailedTest">
			<xsl:with-param name="CategoryName">
				<xsl:value-of select="@name"/>
			</xsl:with-param>
			<xsl:with-param name="NodeList" select="." />
			<xsl:with-param name="PointPenalty" select="-1" />
			<xsl:with-param name="Explanation">Your recursive multiplication isn't multiplying two negative numbers together correctly</xsl:with-param>
		</xsl:call-template>
	</xsl:template>

	<xsl:template match="Category[@name='Recursive Multiplication With Zero']">
		<xsl:call-template name="GenerateFailedTest">
			<xsl:with-param name="CategoryName">
				<xsl:value-of select="@name"/>
			</xsl:with-param>
			<xsl:with-param name="NodeList" select="." />
			<xsl:with-param name="PointPenalty" select="-1" />
			<xsl:with-param name="Explanation">Your recursive multiplication isn't multiplying zero correctly (all non-zero numbers are positive)</xsl:with-param>
		</xsl:call-template>
	</xsl:template>

	<xsl:template match="Category[@name='LL RecursivelyPrintForward']">
		<xsl:call-template name="GenerateFailedTest">
			<xsl:with-param name="CategoryName">
				<xsl:value-of select="@name"/>
			</xsl:with-param>
			<xsl:with-param name="NodeList" select="." />
			<xsl:with-param name="PointPenalty" select="-1" />
			<xsl:with-param name="Explanation">Your RecursivelyPrintForward routine isn't printing correctly</xsl:with-param>
		</xsl:call-template>
	</xsl:template>
	<xsl:template match="Category[@name='LL RecursivelyPrintBackward']">
		<xsl:call-template name="GenerateFailedTest">
			<xsl:with-param name="CategoryName">
				<xsl:value-of select="@name"/>
			</xsl:with-param>
			<xsl:with-param name="NodeList" select="." />
			<xsl:with-param name="PointPenalty" select="-1" />
			<xsl:with-param name="Explanation">Your RecursivelyPrintBackward routine isn't printing correctly</xsl:with-param>
		</xsl:call-template>
	</xsl:template>
	<xsl:template match="Category[@name='LL RecursivelyPrint Foward']">
		<xsl:call-template name="GenerateFailedTest">
			<xsl:with-param name="CategoryName">
				<xsl:value-of select="@name"/>
			</xsl:with-param>
			<xsl:with-param name="NodeList" select="." />
			<xsl:with-param name="PointPenalty" select="-1" />
			<xsl:with-param name="Explanation">Your RecursivelyPrint routine isn't printing correctly (when printing the list forwards)</xsl:with-param>
		</xsl:call-template>
	</xsl:template>
	<xsl:template match="Category[@name='LL RecursivelyPrint Backward']">
		<xsl:call-template name="GenerateFailedTest">
			<xsl:with-param name="CategoryName">
				<xsl:value-of select="@name"/>
			</xsl:with-param>
			<xsl:with-param name="NodeList" select="." />
			<xsl:with-param name="PointPenalty" select="-1" />
			<xsl:with-param name="Explanation">Your RecursivelyPrint routine isn't printing correctly (when printing the list backwards)</xsl:with-param>
		</xsl:call-template>
	</xsl:template>


	<!-- These tests are not actually being graded -->

	<xsl:template match="Category[@name='Recursive Power Pos']">
		<xsl:call-template name="GenerateFailedTest">
			<xsl:with-param name="CategoryName">
				<xsl:value-of select="@name"/>
			</xsl:with-param>
			<xsl:with-param name="NodeList" select="." />
			<xsl:with-param name="PointPenalty" select="-2" />
			<xsl:with-param name="Explanation">Your recursive power function is NOT correctly raising a base to an exponent (both base and exponent are positive integers)</xsl:with-param>
		</xsl:call-template>
	</xsl:template>

	<xsl:template match="Category[@name='Recursive Power With Zero']">
		<xsl:call-template name="GenerateFailedTest">
			<xsl:with-param name="CategoryName">
				<xsl:value-of select="@name"/>
			</xsl:with-param>
			<xsl:with-param name="NodeList" select="." />
			<xsl:with-param name="PointPenalty" select="-1" />
			<xsl:with-param name="Explanation">Your recursive power function is NOT correctly raising a base to an exponent (both base and exponent are EITHER positive integers, or ZERO)</xsl:with-param>
		</xsl:call-template>
	</xsl:template>

</xsl:stylesheet>

