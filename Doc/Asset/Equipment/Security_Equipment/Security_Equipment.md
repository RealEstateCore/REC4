[Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Security_Equipment](.)
# Security_Equipment

**Display name:** Security Equipment<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Security_Equipment;1

---


## Child interfaces
* [Intrusion_Detection_Equipment](Intrusion_Detection_Equipment.md)
* [Access_Control_Equipment](Access_Control_Equipment/Access_Control_Equipment.md)
* [Intercom_Equipment](Intercom_Equipment/Intercom_Equipment.md)
* [Video_Surveillance_Equipment](Video_Surveillance_Equipment/Video_Surveillance_Equipment.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** feeds, isFedBy
* **dtmi:org:w3id:rec:Asset;1:** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** operationalStageCount
* **dtmi:org:w3id:rec:Asset;1:** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight
## Target Of
### Inherited
* Asset.hasPart
* Asset.isPartOf
* EquipmentCollection.includes
