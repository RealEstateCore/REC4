[Index](../../../../../Index.md) > [Asset](../../../../Asset.md) > [Equipment](../../../Equipment.md) > [HVAC_Equipment](../../HVAC_Equipment.md) > [Terminal_Unit](../Terminal_Unit.md) > [Radiator](#)
# Radiator

**Display name:** Radiator<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Radiator;1

---

## Child interfaces
* [Baseboard_Radiator](Baseboard_Radiator/Baseboard_Radiator.md)
* [Electric_Radiator](Electric_Radiator/Electric_Radiator.md)
* [Hot_Water_Radiator](Hot_Water_Radiator/Hot_Water_Radiator.md)
* [Steam_Radiator](Steam_Radiator/Steam_Radiator.md)

---

## Relationships

### Inherited Relationships
* **[Equipment](../../../Equipment.md):** feeds, isFedBy
* **[Asset](../../../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

### Inherited Properties
* **[Equipment](../../../Equipment.md):** operationalStageCount
* **[Asset](../../../../Asset.md):** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### Inherited
* [Asset](../../../../Asset.md).hasPart
* [Asset](../../../../Asset.md).isPartOf
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).includes
* [Loop](../../../../../Collection/Loop/Loop.md).includes
* [System](../../../../../Collection/System/System.md).includes
