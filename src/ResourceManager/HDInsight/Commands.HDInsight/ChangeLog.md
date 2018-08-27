<!--
    Please leave this section at the top of the change log.

    Changes for the current release should go under the section titled "Current Release", and should adhere to the following format:

    ## Current Release
    * Overview of change #1
        - Additional information about change #1
    * Overview of change #2
        - Additional information about change #2
        - Additional information about change #2
    * Overview of change #3
    * Overview of change #4
        - Additional information about change #4

    ## YYYY.MM.DD - Version X.Y.Z (Previous Release)
    * Overview of change #1
        - Additional information about change #1
-->
## Current Release

## Version 4.1.7
* Fixed issue with default resource groups not being set.

## Version 4.1.6
* Updated to the latest version of the Azure ClientRuntime.

## Version 4.1.5
* Updated help files to include full parameter types and correct input/output types.

## Version 4.1.4
* Fixed formatting of OutputType in help files

## Version 4.1.3
* Set minimum dependency of module to PowerShell 5.0

## Version 4.1.2
* Updated to the latest version of the Azure ClientRuntime

## Version 4.1.1
* Fix issue with Default Resource Group in CloudShell

## Version 4.1.0
* Fixed issue with importing aliases

## Version 4.0.2
* Added Location Completer to -Location parameters allowing tab completion through valid Locations
* Added ResourceGroup Completer to -ResourceGroup parameters allowing tab completion through resource groups in current subscription

## Version 4.0.1
* Fixed assembly loading issue that caused some cmdlets to fail when executing

## Version 4.0.0
* Add support for online help
    - Run Get-Help with the -Online parameter to open the online help in your default Internet browser

## Version 3.4.1
* Added support for Data Disks property in cluster creation
    - Added parameter 'WorkerNodeDataDisksGroups' to the New-AzureHDInsightCluster cmdlet

## Version 3.4.0

## Version 3.3.1

## Version 3.3.0

## Version 3.2.1

## Version 3.2.0
* Added support to enable / disable Operations Management Suite(OMS)
* New cmdlets
    - Enable-AzureRmHDInsightOperationsManagementSuite
    - Disable-AzureRmHDInsightOperationsManagementSuite
    - Get-AzureRmHDInsightOperationsManagementSuite
* Add new parameters to set Spark custom configurations to Add-AzureRmHDInsightConfigValues
    - Parameters SparkDefaults and SparkThriftConf for Spark 1.6
    - Parameters Spark2Defaults and Spark2ThriftConf for Spark 2.0

## Version 3.1.0

## Version 3.0.1

## Version 3.0.0

## Version 2.8.0
* Added support for RServer cluster type
    - Edgenode VM size can be specified for RServer cluster in New-AzureRmHDInsightCluster or New-AzureRmHDInsightClusterConfig
    - RServer is now a configuration option in Add-AzureRmHDInsightConfigValues. It allows for RStudio flag to be set to indicate that R Studio installation should be done.

## Version 2.7.0

## Version 2.6.0

## Version 2.5.0

## Version 2.4.0

## Version 2.3.0
* Add support to create HDInsight Spark 2.0 cluster using new cmdlet Add-AzureRmHDInsightComponentVersion to specify the component version of Spark
* Get-AzureRmHDInsightCluster now returns the component version in a Spark 2.0 cluster
* New cmdlet
    - Add-AzureRmHDInsightSecurityProfile