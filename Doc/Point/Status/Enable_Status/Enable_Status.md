[Point](../../Point.md) > [Status](../Status.md) > [Enable_Status](.)
# Enable_Status

**Display name:** Enable Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Enable_Status;1

---


## Child interfaces
* [Heat_Exchanger_System_Enable_Status](../System_Status/Heat_Exchanger_System_Enable_Status.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
