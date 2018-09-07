﻿' REMARQUE : vous pouvez utiliser la commande Renommer du menu contextuel pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
<ServiceContract()>
Public Interface IService1

    <OperationContract()>
    Function GetData(ByVal value As Integer) As String

    <OperationContract()>
    Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType

    <OperationContract()>
    Function MessageAnneChoisir(ByVal dateDeNaissance As Integer) As String

End Interface

' Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
' Vous pouvez ajouter des fichiers XSD au projet. Une fois le projet généré, vous pouvez utiliser directement les types de données qui y sont définis, avec l'espace de noms "WcfServiceLibraryAge.ContractType".

<DataContract()>
Public Class CompositeType

    <DataMember()>
    Public Property BoolValue() As Boolean

    <DataMember()>
    Public Property StringValue() As String

End Class
