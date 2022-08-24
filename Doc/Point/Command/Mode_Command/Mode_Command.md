[Point](../../Point.md) > [Command](../Command.md) > [Mode_Command](#)
# Mode_Command

**Display name:** Mode Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Mode_Command;1

---


## Child interfaces
* [Automatic_Mode_Command](Automatic_Mode_Command.md)
* [Box_Mode_Command](Box_Mode_Command.md)
* [Maintenance_Mode_Command](Maintenance_Mode_Command.md)

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
