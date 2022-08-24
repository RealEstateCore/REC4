[Point](../../Point.md) > [Sensor](../Sensor.md) > [Enthalpy_Sensor](#)
# Enthalpy_Sensor

**Display name:** Enthalpy Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Enthalpy_Sensor;1

---


## Child interfaces
* [Air_Enthalpy_Sensor](Air_Enthalpy_Sensor/Air_Enthalpy_Sensor.md)

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
