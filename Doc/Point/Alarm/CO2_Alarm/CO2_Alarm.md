[Point](../../Point.md) > [Alarm](../Alarm.md) > [CO2_Alarm](#)
# CO2_Alarm

**Display name:** CO2 Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:CO2_Alarm;1

---


## Child interfaces
* [High_CO2_Alarm](High_CO2_Alarm.md)

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
